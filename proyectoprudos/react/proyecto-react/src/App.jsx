import{BrowserRouter, Routes, Route } from "react-router-dom";
import Nav from './Components/Nav';
import Bodegas from './Views/Bodegas/Index';
import Graphinc from './Views/Empleados/Graphic';
import Empleados from './Views/Empleados/Index';
import Login from './Views/Login';
import Register from './Views/Register';
import ProtectdRoutes from './Components/ProtectdRouted';

function App() {
  return (
    <BrowserRouter>
    <Nav/>
      <Routes>
        <Route path="/login" element={<Login/>}/>
        <Route path="/register" element={<Register/>}/>
        <Route path="/" element={<Bodegas />}/>
        <Route path="/empleados" element={<Empleados />}/>
        <Route path="/graphic" element={<Graphinc />}/>
       

      </Routes>
    

    </BrowserRouter>
    
  )
}

export default App
