import React, { useEffect, useState } from 'react'

 const suggestionData = [
        "laptop",
        "mobile",
        "phone",
        "mango",
        "modi",
        "lapu"
    ]

export default function UseEffectComponent() {
    const [search, setSearch] = useState("");

    const [recomendation, setRecomendation] = useState(suggestionData);
    
       
    useEffect(()=>{
        setRecomendation(suggestionData.filter((elem) => elem.includes(search)))
        console.log("UseEffect is triggered");
        
    
    },[search]);


  return (
    <div>
      <input type="text" value={search} onChange={(e) => setSearch(e.target.value)} />
      {
        recomendation.map((element) => <div> {element} </div>)
        
      }
    </div>
  )
}
