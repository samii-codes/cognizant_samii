import logo from './logo.svg';
import './App.css';
import { useState } from 'react';



function App(){
  const [loggedIn, setLoggedIn] = useState(false);

  function handleLogin(){
    setLoggedIn(true);
  }
  function handleLogout(){
    setLoggedIn(false);
  }
  return(
    <div>
      {loggedIn?(<div>
        <h1>Welcome Back</h1>
        <button onClick={handleLogout}>Logout</button>
        </div>
        ): (
        <div>
          <h1>Please sign up.</h1>
          <button onClick={handleLogin}>Login</button>
        </div>
      )}
    </div>
  );
}



export default App;
