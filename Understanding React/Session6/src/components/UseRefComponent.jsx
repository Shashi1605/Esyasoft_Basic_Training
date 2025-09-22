import React,{useRef, useState} from 'react'

export default function UseRefComponent() {

    const[count, SetCounter] = useState(1);
    const increament = ()=>{
        SetCounter(count => count * 2);
    }

    const decrement = ()=>{
        SetCounter(count => count - 1);
    }

    return (
    <div>
      Welcome to the parent components {count}
      {sibling1(count)}
      {(sibling2(increament, decrement))}
    </div>
  )
}

function sibling1({count}){
    return(
        <div>
           
        </div>
    )
}

function sibling2(increament, decrement){
    return (
        <>
        <div>
            <button onClick={()=>increament}>increament</button>
            <button onClick={()=>decrement}>decrement</button>
        </div>
        </>
    )
}