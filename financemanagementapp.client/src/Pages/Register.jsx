import React from 'react'
import { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';


const Register = () => {
    document.title = "Register"

    // Don't ask an already register in user to register over and over again
    useEffect(()=>{
        const user = localStorage.getItem("user")
        if(user){
            document.location = "/"
        }
    },[]);
  return (
    <div className="auth-container">
        <div className="background">
            <div className="shape"></div>
            <div className="shape"></div>
        </div>
        <form action="#" onSubmit={registerHandler}>
            <h3>Register Here</h3>
            <label htmlFor="name">Name</label>
            <input type="text" placeholder="Name" id="name" name='Name' required></input>

            <label htmlFor="email">Email</label>
            <input type="email" placeholder="Email" id="email" name='email' required></input>

            <label htmlFor="password">Password</label>
            <input type="password" placeholder="Password" id="password" name='PasswordHash' required></input>

            <button>Login</button>
            <input type="submit" value="Register"></input>
    
        </form>
        <p className='message'></p>
    </div>
  )
  async function registerHandler(e){
    e.preventDefault()
    const form_ = e.target, submitter = document.querySelector("input.login")
    const formData = new FormData(form_, submitter), dataToSend = {}
    
    for(const [key, value] of formData){
        dataToSend[key] = value
    }

    // create  username
    const newUserName = dataToSend.Name.trim().split(" ")
    dataToSend.UserName = newUserName.join("")

    const response = await fetch("https://localhost:7035/api/FMA/register", {
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
        document.location = "/login"
    }

    const messageE1 = document.querySelector(".message")
    if(data.messsage){
        messageE1.innerHTML = data.messsage
    } else{
        let errorMessages = "<div>Attention please:</div><div class='normal'>"
        data.errors.forEach(error => {
            errorMessages += error.description + " "
        })
        errorMessages += "</div>"
        messageE1.innerHTML = errorMessages
    }

    console.log("login error: ", data);
  }
}

export default Register


/* 
<div className="auth-container">
        <div className="background">
            <div className="shape"></div>
            <div className="shape"></div>
        </div>
        <form>
            <h3>Register Here</h3>
            <label htmlFor="email">Email</label>
            <input type="email" placeholder="Email" id="email" name='email' value={email} onChange={handleChange}></input>

            <label htmlFor="password">Password</label>
            <input type="password" placeholder="Password" id="password" name='password' value={password} onChange={handleChange}></input>

            <label htmlFor="confirmPassword">Confirm Password</label>
            <input type="password" placeholder="Confirm Password" id="confirmPassword" name='confirmPassword' value={confirmPassword} onChange={handleChange}></input>

            <button>Register</button>
            <button onClick={handleLoginClick}>Go to Login</button>  
        </form>

        {error && <p className="error">{error}</p>}
    </div>
*/