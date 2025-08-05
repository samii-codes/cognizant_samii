import logo from './logo.svg';
import './App.css';
import officeSpace from './download.jpg';

const content={
  Name:"DBS",
  Rent:50000,
  Address:"Chennai"
};

const color=content.Rent<50000?"red":"green";

function App(){
  const heading="Office Space, at Affordable Range";
  
  return (
    <div className="text-center">
      <h1>{heading}</h1>
      <img src={officeSpace} width="25%" height="25%" alt="Office Space" />
      <div>
        <h2>Name: {content.Name}</h2>
        <h2 style={{color:color}}>Rent: {content.Rent}</h2>
        <h2>Address: {content.Address}</h2>
      </div>
    </div>
  )
}

export default App;
