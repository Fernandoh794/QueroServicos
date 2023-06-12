import React from 'react';
import './style.css'
import Image from '../assets/home.png'
function Home() {
    return (
        <div id='area1'>
            <div id='areaLeft'>
                <span style={{ fontSize: 35, alignSelf: 'end', textAlign: 'end', marginRight: '20%' }}>A melhor <strong>solução</strong><br />
                    para o seu <span style={{ color: '#390099' }}>problema.</span></span>
                <div id='faixa'></div>
                <span style={{ fontSize: 22, alignSelf: 'end', textAlign: 'end', marginRight: '20%' }}>
                    encontre o profissional ideal para<br />cada tipo de problema.
                </span>
            </div>
            <div id='areaRight'>
                <img src={Image} alt='HomeImage' style={{ height: '75vh' }} />
            </div>
        </div>
    )
}

export default Home;