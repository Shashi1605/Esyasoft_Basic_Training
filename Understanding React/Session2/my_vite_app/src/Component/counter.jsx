import React, { useState } from "react";

function Counter(){
    const[cnt, setcnt] = useState(0);
    const increment = () =>{
        setcnt(cnt=> cnt+1);
    }

    const name = 'shashi';

    const currentDate= ()=>{
        let Abc = new Date();
        let date ={
            
             day : Abc.getDate(),
             month : Abc.getMonth(),
             year : Abc.getFullYear(),
        }
        const {day, month, year} = date;
        return date;

        }


       //spread operator
       const spread = ()=>{
        let name1 = {Name : "shashi", age : 23};
        name1 = {...name1, age : 25};
        let name2 = {age:22, ...name1};
       console.log(name1);
       console.log(name2); 
       }

       spread();
        
    
    return (
       <div>
         <h1 id = "c">{cnt}</h1>
        <button onClick={increment}>Inc</button>

        <h1>Hello {name}</h1>
        <h1>Current date: {currentDate().day}/{currentDate().month}/{currentDate().year}</h1>

       </div>
    )
}

export default Counter;