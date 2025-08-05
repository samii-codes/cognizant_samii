import React from 'react';

const BlogDetails = ({ blogs }) => {
  return (
    <div className="section">
      <h1>Blog Details</h1>
      {blogs.map(blog => (
        <div key={blog.id} className="item">
          <h3>{blog.title}</h3>
          <h4>{blog.author}</h4>
          <p>{blog.content}</p>
        </div>
      ))}
    </div>
  );
};

export default BlogDetails;