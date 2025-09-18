import React, { useState } from 'react'

export default function LoginComponent() {

    const [username, setUsername] = useState("")
    const [password, setPassword] = useState("")

    const loginHangler = ()=>{
        if(username !== `username`){
            alert("Invalid username")
            return;
        }
        if(password !== `password`){
            alert(`Invalid Password`)
            return;
        }
        alert("Login Successfull")
    }
  return (
    <div>
        <input type="text" value={username} onChange={(e)=>{setUsername(e.target.value)}} placeholder='Enter your User Name' />
        <input type="password" value={password} onChange={(e)=> {setPassword(e.target.value)}} placeholder='Enter your Password' />
        <button onClick={loginHangler}>Submit</button>
      
    </div>
  )
}
