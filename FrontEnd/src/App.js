import { BrowserRouter as Router, Routes, Route, Link, BrowserRouter } from 'react-router-dom';
import Index from './Pages/Index';
import Login from './Pages/Login';
import Register from './Pages/Register';
import Home from './Pages/Home';
import DatePage from './Pages/DatePage';
import Profile from './Pages/Profile';
function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Index />} />
        <Route path='/login' element={<Login />} />
        <Route path='/register' element={<Register />} />
        <Route path='/home' element={<Home />} />
        <Route path='/datePage' element={<DatePage />} />
        <Route path='/profile' element={<Profile />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;