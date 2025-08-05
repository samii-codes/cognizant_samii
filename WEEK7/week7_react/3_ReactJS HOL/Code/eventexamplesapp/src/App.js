import logo from './logo.svg';
import './App.css';
import Reacr,{ useState } from 'react';
import CurrencyConverter from './Components/CurrencyConverter';

function App() {
  const [counter, setCounter] = useState(0);
  const [currentcy, setCurrentcy] = useState(0);
  function increment() {
    setCounter(counter + 1);
    hello();
  }
  function decrement() {
    setCounter(counter - 1);
  }
  function hello() {
    alert("Counter value is: " + counter);
  }
  function onIncrement(){
    increment();
    
  }
  function clickMe(){
    alert("I am clicked");
  }
  return(
    <div>
      <h1>{counter}</h1>
      <button onClick={onIncrement}>Increment</button>
      <br/>
      <button onClick={decrement}>Decrement</button>
      <br/>
      <button onClick={()=>alert("Welcome")}>Say Welcome</button>
      <br/>
      <button onClick={clickMe}>Click Me</button>
      <CurrencyConverter/>
    </div>
  )
}

export default App;
