import React,{useState} from 'react';

function CurrencyConverter(){
    const [rupees,setRupees]= useState(0);
    const conversion=()=>{
        const euro= rupees * 0.011;
        alert(`${rupees} is equal to ${euro.toFixed(2)} Euros`);
    }

    const change=(event)=>{
        setRupees(event.target.value);
    }
    return(
        <div>
            <h1 style={{color:"green"}}>Currency Converter!!!</h1>
            <label>Amount:</label>
            <input type="number" value={rupees} onChange={change}></input>
            <br/>
            <label>Currency:</label>
            <input type="text" value="Euros" readOnly></input>
            <br/>
            <button onClick={conversion}>Convert</button>
        </div>
    );
}

export default CurrencyConverter;