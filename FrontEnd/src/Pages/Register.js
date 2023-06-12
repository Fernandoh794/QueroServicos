import React from 'react';
import './styles.css';
import Image from '../assets/image-register.png';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
function Register() {
    return (
        <div id='containerRegister'>
            <div id='areaLeftRegister'>
                <span style={{ color: '#FFF', marginRight: '20%' }}>
                    O primeiro passo para <br />
                    <strong>solucionar</strong> o seu problema.
                </span>
                <div id='faixaBranca'></div>
            </div>

            <div id='areaRightRegister'>
                <span style={{ fontSize: 25, margin: 25 }}><strong>Quero</strong><span style={{ color: '#390099' }}>Serviços</span></span>
                <TextField style={{ marginBottom: 22, width: '60%' }} id="outlined-basic" label="Nome Completo" variant="outlined" />
                <TextField style={{ marginBottom: 22, width: '60%' }} id="outlined-basic" label="CNPJ/CPF" variant="outlined" />
                <TextField style={{ marginBottom: 22, width: '60%' }} id="outlined-basic" label="E-mail" variant="outlined" />
                <TextField style={{ marginBottom: 22, width: '60%' }} id="outlined-basic" label="Telefone" variant="outlined" />
                <br/>
                <TextField style={{ marginBottom: 22, width: '60%' }} id="outlined-basic" label="Crie uma senha" variant="outlined" />
                <TextField style={{ marginBottom: 22, width: '60%' }} id="outlined-basic" label="Confirme a senha" variant="outlined" />

                <Button style={{marginBottom: 20}} variant="contained">Salvar</Button>
            </div>
        </div>
    )
}

export default Register;