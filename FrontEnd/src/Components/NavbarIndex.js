import React from 'react'
import './style.css'
import Button from '@mui/material/Button';

function NavbarIndex() {
    return (
        <div id='container'>
            <div id='area'>
                <span style={{ fontSize: 22, marginLeft: '55%' }}><strong>Quero</strong><span style={{ color: '#390099' }}>Serviços</span></span>
            </div>

            <div id='area'>
                <a href='#home'>Home</a>|
                <a href='#conheca'>Conheça</a>|
                <a href='#servico'>Serviços</a>|
                <a href='#contato'>Contato</a>
            </div>

            <div id='areaButton'>
                <div id='buttonLogin'>
                    <a href='/login'>Login</a>
                </div>

                <Button variant="contained" href='/register'>Registre-se</Button>
            </div>
        </div>
    )
}

export default NavbarIndex;