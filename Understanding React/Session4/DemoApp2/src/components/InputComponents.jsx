import React from 'react'

export default function InputComponents() {

    const dumyjson = {
        "firstName" : "Shashi",
        "lastName" : "Kumar",
        "target" : {
            "value" : "abc"
        }
    }

    const onhange = (e)=>{
        console.log(e.firstName)
    }

  return (
    <div>
      <input type="text" />
      <button onClick={() => onhange(dumyjson)}>Click</button>
    </div>
  )
}
