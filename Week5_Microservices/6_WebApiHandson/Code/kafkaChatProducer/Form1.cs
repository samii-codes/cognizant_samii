using Confluent.Kafka;  // Add this NuGet package

namespace kafkaChatProducer
{
    public partial class Form1 : Form
    {
        private readonly ProducerConfig config;

        public Form1()
        {
            InitializeComponent();

            // Initialize Kafka producer config once
            config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var message = txtMessage.Text;

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            try
            {
                var deliveryResult = await producer.ProduceAsync("chat-messages", new Message<Null, string> { Value = message });

                MessageBox.Show($"Message sent to {deliveryResult.TopicPartitionOffset}");
            }
            catch (ProduceException<Null, string> ex)
            {
                MessageBox.Show($"Failed to deliver message: {ex.Error.Reason}");
            }
        }
    }
}
