import { BrowserRouter as Router, Routes, Route, Link, BrowserRouter } from 'react-router-dom';
import Index from './Pages/Index';
import Login from './Pages/Login';
import Register from './Pages/Register';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Index />} />
        <Route path='/login' element={<Login />} />
        <Route path='/register' element={<Register />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;