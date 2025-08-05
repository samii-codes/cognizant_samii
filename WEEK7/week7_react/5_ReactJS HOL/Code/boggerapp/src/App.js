import React from 'react';
import './App.css';
import BookDetails from './Components/bookDetails.js';
import BlogDetails from './Components/blogDetails.js';
import CourseDetails from './Components/courseDetails.js';

// Data for the components
const booksData = [
  { id: 101, bname: 'Master React', price: 670 },
  { id: 102, bname: 'Deep Dive Into Angular 11', price: 800 },
  { id: 103, bname: 'Mongo Essentials', price: 450 },
];

const blogsData = [
  { id: 201, title: 'React Learning', author: 'Stephen Biz', content: 'Welcome to learning React!' },
  { id: 202, title: 'Installation', author: 'Schewzdenier', content: 'You can install React from npm.' },
];

const coursesData = [
  { id: 301, name: 'Angular', date: '4/5/2021' },
  { id: 302, name: 'React', date: '6/3/2020' },
];

function App() {
  return (
    <div className="App">
      <div className="container">
        <CourseDetails courses={coursesData} />
        <BookDetails books={booksData} />
        <BlogDetails blogs={blogsData} />
      </div>
    </div>
  );
}

export default App;