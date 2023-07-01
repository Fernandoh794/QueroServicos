import React from 'react';
import NavbarHome from '../Components/NavbarHome';
import TextField from '@mui/material/TextField';
import ItemBox from '../Components/itemBox';
import Cartao from '../Components/Cartao'
function Home() {
    return (
        <div id='containerHome'>
            <header>
                <NavbarHome />
            </header>
            <body id='bodyHome'>
                <br></br>
                <TextField style={{ width: '80%', display: 'flex', margin: 'auto' }} fullWidth label="Buscar" id="fullWidth" />
                <br></br>
                <div style={{padding: 'auto', display: 'flex', flexDirection: 'column' }}>
                    <ItemBox />
                    <div style={{height: '5vh', backgroundColor: '#390099', width: '80%', margin: 'auto', borderRadius: 10, color: '#FFF', textAlign: 'center', fontSize: 22}}>
                        Lagarto
                    </div>
                    <Cartao/>
                </div>

            </body>
        </div>
    )
}

export default Home;