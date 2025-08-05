import React from 'react';

const CourseDetails = ({ courses }) => {
  return (
    <div className="section">
      <h1>Course Details</h1>
      {courses.map(course => (
        <div key={course.id} className="item">
          <h3>{course.name}</h3>
          <h4>{course.date}</h4>
        </div>
      ))}
    </div>
  );
};

export default CourseDetails;