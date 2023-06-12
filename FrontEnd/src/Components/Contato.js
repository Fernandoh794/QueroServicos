import React from 'react';
import './style.css';
import Image from '../assets/contato.png'

function Contato(){
    return(
        <div id='containerContato'>
            <div id='areaLeftContato'>
                <img  src={Image} style={{height: '85vh'}}/>
            </div>

            <div id='areaCenterContato'>
                <span>Nome</span>
                <input placeholder='digite seu nome completo' id='input'></input>

                <span>E-mail</span>
                <input placeholder='digite seu e-mail' id='input'></input>

                <span>Telefone</span>
                <input placeholder='digite seu telefone' id='input'></input>

                <button id='buttonContato'>enviar</button>
            </div>

            <div id='areaRightContato'></div>
        </div>
    )
}

export default Contato;
