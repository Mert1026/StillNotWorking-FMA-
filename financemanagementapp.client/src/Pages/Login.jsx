import React from 'react'
import { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';


const Login = () => {
    document.title = "Login"

    // Don't ask an already logged in user to login over and over again
    useEffect(()=>{
        const user = localStorage.getItem("user")
        if(user){
            document.location = "/"
        }
    }
    )
  return (
    <div className="auth-container">
        <div className="background">
            <div className="shape"></div>
            <div className="shape"></div>
        </div>
        <form action="#" onSubmit={loginHandler}>
            <h3>Login Here</h3>
            <label htmlFor="email">Email</label>
            <input type="email" placeholder="Email" id="email" name='email' required></input>

            <label htmlFor="password">Password</label>
            <input type="password" placeholder="Password" id="password" name='Password' required></input>

            <input type='checkbox' id='remember' name='Remember' ></input>
            <span>Remember Me</span>

            <button>Login</button>
            <input type="submit" value="Login"></input>
    
        </form>
        <p className='message'></p>
    </div>
  )
  async function loginHandler(e){
    e.preventDefault()
    const form_ = e.target, submitter = document.querySelector("input.login")
    const formData = new FormData(from_, submitter), dataToSend = {}
    
    for(const [key, value] of formData){
        dataToSend[key] = value
    }

    if (dataToSend.Remember === "on"){
        dataToSend.Remember = true
    }

    const response = await fetch("api/SecureWebsite/login", {
        method: "POST",
        credentials: "include",
        body: JSON.stringify(dataToSend),
        headers: {
            "content-type" : "Application/json",
            "Accept" : "application/json"
        }
    })

    const data = await response.json()

    if(response.ok){
        localStorage.setItem("user", dataToSend.Email)
        document.location = "/"
    }

    const messageE1 = document.querySelector(".message")
    if(data.messsage){
        messageE1.innerHTML = data.messsage
    } else{
        messageE1.innerHTML = "Something went wrong, please try again"
    }

    console.log("login error: ", data);
  }
}

export default Login
