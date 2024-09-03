import React from 'react'
import Navbar from './Components/Navbar'
import Home from './Pages/Home'
import Login from './Pages/Login'
import Register from './Pages/Register'
import { BrowserRouter as Router, Route, Routes, createBrowserRouter, createRoutesFromElements, RouterProvider } from 'react-router-dom'
import ProtectedRoutes from './Components/ProtectedRoutes'
import Admin from './Pages/Admin'

const router = createBrowserRouter(
    createRoutesFromElements(
        <Route path='/'>
            <Route element={<ProtectedRoutes/>}>
                <Route path='/' element={<Home/>}/>
                <Route path='/admin' element={<Admin/>}/>
            </Route>
            <Route path='/login' element={<Login/>}/>
            <Route path='/register' element={<Register/>}/>
            <Route path='*' element={
                <div>
                    <header>
                        <h1>Not Found</h1>
                    </header>
                    <p>
                        <a href="/">Back to home</a>
                    </p>
                </div>
            }/>
        </Route>
    )
)
const App = () => {
    const isLogged = localStorage.getItem("user");
  return (
        <Router>
            <div className="App">
                <Navbar/>
                <div className="content">
                    <Routes>
                        <Route path="/" element={<Home />}/>
                        <Route path="/admin" element={<Admin />}/>
                        <Route path="/login" element={<Login />}/>
                        <Route path="/register" element={<Register />}/>
                    </Routes>
                </div>
            </div>
        </Router>       
  )
}

export default App;