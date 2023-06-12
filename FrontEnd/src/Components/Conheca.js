import React from 'react';
import './style.css'
import Image from '../assets/conheca.png'
function Conheca() {
    return (
        <div id='area1Conheca'>
            <div id='areaLeftConheca'>
                <img src={Image} alt="ImageConheça" style={{ height: '80vh' }} />
            </div>

            <div id="areaCenterConheca">
                <span>
                    O
                    <strong> Quero</strong>
                    <span style={{ color: '#390099' }}>Serviços </span>
                    é uma plataforma online que conecta <br />
                    pessoas a profissionais da região.
                </span>

                <span style={{textAlign: 'end', marginTop: '25px', marginRight: '8%'}}>
                    Com uma interface amigável é simples encontrar
                    alguém para resolver aquele problema
                    que lhe atormenta.
                </span>
            </div>

            <div id='areaRightConheca'>

            </div>
        </div>
    );
}

export default Conheca;