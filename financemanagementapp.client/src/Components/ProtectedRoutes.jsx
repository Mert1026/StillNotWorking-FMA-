import React from 'react'
import { useState, useEffect} from 'react'
import { Outlet, Navigate } from 'react-router-dom'

const ProtectedRoutes = () => {
    const [isLogged, setIsLogged] = useState(false);
    const [waiting, setWaiting] = useState(true);

    useEffect(() => {
        fetch("api/SecureWebsite/xhtlekd",{
            method: "GET",
            credentials: "include"
        }).then(response => response.json()).then(data => {
            setIsLogged(true)
            setWaiting(false)
            localStorage.setItem("user", data.user.email)
            console.log(data.user)
        }).catch(err => {
            console.log("Error protected routes: ", err)
            setWaiting(false)
            localStorage.removeItem("user")
        })
    }

    )

  return waiting ? <div className='waiting-page'>
    <div>Waiting...</div>
  </div> :
  isLogged ? <Outlet/> : <Navigate to="/login"/>
}

export default ProtectedRoutes
