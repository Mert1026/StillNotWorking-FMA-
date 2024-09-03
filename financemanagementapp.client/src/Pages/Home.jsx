import React from 'react'
import { useEffect, useState } from 'react'

const Home = () => {
  document.title = "Welcome"
  const [userInfo, setUserInfo] = useState({})

  useEffect(()=>{
    const user = localStorage.getItem("user")
    fetch("api/SecureWebSite/home/" + user, {
      method: "GET",
      credentials: "include"
    }).then(response => response.json()).then(data => {
      setUserInfo(data.userInfo)
      console.log("user info: ", data.userInfo)
    }).catch(error => {
      console.log("Error home page: ", error)
    })
  },[]
  )

  return (
    <div className='home-container'>
      <h1>Welcome</h1>
      {
              userInfo ?
              <div>
                <table>
                  <thread>
                    <tr>
                      <th>Name</th>
                      <th>Email</th>
                      <th>Created Date</th>
                    </tr>
                  </thread>
                  <tbody>
                    <tr>
                      <td>{userInfo.name}</td>
                      <td>{userInfo.email}</td>
                      <td>{userInfo.createdDate ? userInfo.createdDate.split(":")[0] : ""}</td>
                    </tr>
                  </tbody>
                </table>
              </div> :
              <div className='warning'>
                <div>Access Denied!!!</div>
              </div>
      }
    </div>
  )
}

export default Home
