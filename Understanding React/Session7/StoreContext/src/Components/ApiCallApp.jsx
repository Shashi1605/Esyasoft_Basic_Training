import React, { use, useState } from 'react'

export default function ApiCallApp() {

    const [data, setData] = useState([])
    const getData = ()=>{
        fetch("https://jsonplaceholder.typicode.com/posts")
        .then((data)=> data.json())
        .then((jsonData)=> setData(jsonData))
        
    }

    // getData()

  return (
    <div>
        <button onClick={getData}>click</button>
        {data.map((element) => <p key = {element.id}> {element.id}. {element.title}</p>)}
    </div>
  )
}
