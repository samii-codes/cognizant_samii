import React from 'react';

class Posts extends React.Component {

  constructor(props) {
    super(props); 
    this.state = {
      posts: [],
      error: null
    };
  }
  loadPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => response.json())
      .then(data => {
        this.setState({ posts: data });
      })
      .catch(error => {
        this.setState({ error: error });
      });
  }

  
  componentDidMount() { 
    this.loadPosts(); 
  }


  componentDidCatch(error, info) { 
    alert('An error occurred: ' + error.message); 
  }


  render() {
    const { posts, error } = this.state;

    
    if (error) {
      return <div>Error: {error.message}</div>;
    }

    
    if (posts.length === 0) {
      return <div>Loading posts...</div>;
    }


    return (
      <div>
        <h1>Blog Posts</h1>
        {posts.map(post => (
          <div key={post.id} style={{ borderBottom: '1px solid #ccc', marginBottom: '20px', paddingBottom: '20px' }}>
            <h2>{post.title}</h2>
            <p>{post.body}</p>
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;