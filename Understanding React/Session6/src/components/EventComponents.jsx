import React from 'react'

export default function EventComponents() {

    const greeting = ()=>{
        alert("This is Milkyway Gallexy")
    }

  return (
    <div>
        Wellcome to My World!
        <br/>
        <button onClick={greeting}>Explore</button>
        
        <div style ={{
            background : 'Red',
            padding: '50px',
            borderRadius: '50%',
            color: 'Black'
        }}>
            This is a planet
        </div>
    </div>
  )
}
