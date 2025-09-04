import React, { useState } from "react";

function Counter(){
    // let count = 0;
    // const increment = ()=>{
    //     count++;
    //     document.getElementById("c").innerText =count;
    const[cnt, setcnt] = useState(0);
    const increment = () =>{
        setcnt(cnt=> cnt+1);
    }
    
    return (
       <div>
         <h1 id = "c">{cnt}</h1>
        <button onClick={increment}>Inc</button>
       </div>
    )
}

export default Counter;