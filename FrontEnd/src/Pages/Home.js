import React, { useEffect, useState } from 'react';
import NavbarHome from '../Components/NavbarHome';
import TextField from '@mui/material/TextField';
import ItemBox from '../Components/itemBox';
import MediaCard from '../Components/MediaCard';
import axios from 'axios';

function Home() {
  const [usersData, setUsersData] = useState([]);

  useEffect(() => {
    axios.get('https://localhost:7024/api/Users')
      .then(response => {
        console.log(response.data); // Verificar o formato dos dados recebidos
        setUsersData(response.data);
      })
      .catch(error => {
        console.error(error);
      });
  }, []);

  return (
    <div id='containerHome'>
      <header>
        <NavbarHome />
      </header>
      <body id='bodyHome'>
        <br></br>
        <TextField style={{ width: '80%', display: 'flex', margin: 'auto' }} fullWidth label="Buscar" id="fullWidth" />
        <br></br>
        <div style={{ padding: 'auto', display: 'flex', flexDirection: 'column' }}>
          <ItemBox />
          <div style={{ height: '5vh', backgroundColor: '#390099', width: '80%', margin: 'auto', borderRadius: 10, color: '#FFF', textAlign: 'center', fontSize: 22 }}>
            Lagarto
          </div>
          <div style={{
            display: 'flex',
            flexWrap: 'wrap', 
            display: 'flex', 
            flexDirection: 'row', 
            alignItems: 'center', 
            justifyContent: 'space-between', padding: 25
          }}>
            <MediaCard users={usersData} />
          </div>
        </div>
      </body>
    </div>
  );
}

export default Home;
