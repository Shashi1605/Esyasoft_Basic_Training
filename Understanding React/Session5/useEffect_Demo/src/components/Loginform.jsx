import React, { useState } from 'react'

export default function Loginform() {

    const [loginState, setLoginState] = useState({
        username : "",
        password : ""
    })

    const onUsernameChangeHandler = (event) =>{
        setLoginState({
            ...loginState,
            username:event.target.value
        })
    }

    const onPasswordChangeHandler = (event) =>{
        setLoginState({
            ...loginState,
            password:event.target.value
        })
    }

    const loginHandler = (event)=>{
        event.preventDefault();
        console.log(event.target.user.value);
    }

  return (
    <div>
        <h1>Log in</h1>
        
        <form onSubmit={loginHandler}>
            
            <input type="text" name="user" value={loginState.username} placeholder='Enter your username' onChange={onUsernameChangeHandler}/>
            <br />
            <input type="password" value={loginState.password} placeholder='Enter your password' onChange={onPasswordChangeHandler} />
            <br />
            <button type = 'submit'>Log in</button>
        </form>
    </div>
  )
}
