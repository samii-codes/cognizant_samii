import { CalculateScore } from "./Components/CalculateScore";

function App() {
  return (
    <div>
      <CalculateScore
        Name={"Steeve"}
        School={"DNV publoic school"}
        total={284}
        goal={3}
      />
    </div>
  );
}

export default App;
