import React, { useState } from 'react';
import NavbarHome from '../Components/NavbarHome';
import Container from '@mui/material/Container';
import Button from '@mui/material/Button';
import PersonIcon from '@mui/icons-material/Person';
import SecurityIcon from '@mui/icons-material/Security';
import EqualizerIcon from '@mui/icons-material/Equalizer';
import InfoIcon from '@mui/icons-material/Info';
import TextField from '@mui/material/TextField';
import { css } from './Profile-styles.css';
import Bandeira from '../assets/lagartoflag.jpeg';

export default function Perfil() {
    const [activeTab, setActiveTab] = useState('perfil');

    const handleTabClick = (tab) => {
        setActiveTab(tab);
    };

    return (
        <div>
            <header>
                <NavbarHome />
            </header>
            <body>
                <Container fixed style={{display: 'flex', flexDirection: 'row'}}>
                    <div style={{ flexDirection: 'column', display: 'flex', width: '50%', justifyContent: 'center', alignItems: 'center', height: '85vh' }}>
                        <Button id='btnProfile' className={activeTab === 'perfil' ? 'activeTab' : ''} onClick={() => handleTabClick('perfil')}>
                            <PersonIcon />
                            perfil
                        </Button>
                        <Button id='btnProfile' className={activeTab === 'segurança' ? 'activeTab' : ''} onClick={() => handleTabClick('segurança')}><SecurityIcon />segurança</Button>
                        <Button id='btnProfile' className={activeTab === 'dados' ? 'activeTab' : ''} onClick={() => handleTabClick('dados')}><EqualizerIcon />perfil profissional</Button>
                        <Button id='btnProfile' className={activeTab === 'sobre' ? 'activeTab' : ''} onClick={() => handleTabClick('sobre')}><InfoIcon />sobre</Button>
                    </div>
                    <div style={{ flexDirection: 'column', display: 'flex', width: '50%', justifyContent: 'center', alignItems: 'center', height: '85vh' }}>
                        {activeTab === 'perfil' && (
                            <div id='containerBox'>
                                <h1 >Perfil</h1>
                                <div id='box'>
                                    Dados da conta
                                    <TextField style={{ margin: 10 }} id="outlined-basic" label="Primeiro nome" variant="outlined" />
                                    <TextField style={{ margin: 10 }} id="outlined-basic" label="Último nome" variant="outlined" />
                                    <TextField style={{ margin: 10 }} id="outlined-basic" label="E-mail" variant="outlined" />

                                    <Button variant="contained" style={{ margin: 10 }}>Salvar alterações</Button>
                                </div>
                            </div>
                        )}
                        {activeTab === 'segurança' && (
                            <div id='containerBox'>
                                <h1>Segurança</h1>
                                <div id='box'>
                                    Alterar a senha
                                    <TextField style={{ margin: 10 }} id="outlined-basic" label="Senha atual" variant="outlined" />
                                    <TextField style={{ margin: 10 }} id="outlined-basic" label="Nova senha" variant="outlined" />
                                    <TextField style={{ margin: 10 }} id="outlined-basic" label="Confirme a senha" variant="outlined" />

                                    <Button variant="contained" style={{ margin: 10 }}>Salvar alterações</Button>
                                </div>
                            </div>
                        )}
                        {activeTab === 'dados' && (
                            <div id='containerBox'>
                                <h1>Perfil profissional</h1>
                                <div id='box'></div>
                            </div>
                        )}
                        {activeTab === 'sobre' && (
                            <div id='containerBox'>
                                <h1>Sobre</h1>
                                <div id='box'>
                                    Informações sobre o sistema
                                    <p style={{ textAlign: 'justify' }}>
                                        Desenvolvido por 3 jovens lagartenses para a materia de
                                        programação web II do curso de sistemas de informação,
                                        ministrada pelo professor Francisco Rodrigues, no
                                        IFS - Campus Lagarto.
                                    </p>
                                    <img src={Bandeira} style={{ width: '50%', alignSelf: 'center' }} />
                                    <h4 style={{ margin: 0 }}>#CapitalDoInterior</h4>
                                    <h5 style={{ margin: 0 }}>Lagarto >>>> Itabaiana</h5>
                                </div>
                            </div>
                        )}
                    </div>
                </Container>
            </body>
        </div>
    )
}
