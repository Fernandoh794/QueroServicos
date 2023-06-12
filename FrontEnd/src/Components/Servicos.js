import React from 'react';
import './style.css';
import Image from '../assets/servicos.png';
import IconAuto from '../assets/icon-auto.png';
import IconAssistencia from '../assets/icon-assistencia.png';
import IconAulas from '../assets/icon-aula.png';
import IconDesenvolvimento from '../assets/icon-desenvolvimento.png';
import IconEventos from '../assets/icon-eventos.png';
import IconModa from '../assets/icon-moda.png';
import IconReformas from '../assets/icon-reformas.png';
import IconServicosDom from '../assets/icon-servicosdomesticos.png';
function Servicos() {
    return (
        <div id='containerServicos'>
            <div id='areaLeftServicos'></div>

            <div id='areaCenterServicos'>
                <div id='listServ'>
                    <img src={IconAuto} style={{ width: 60, marginRight: 10 }} />
                    <span>Peças e Auto</span>
                </div>

                <div id='listServ'>
                    <img src={IconAssistencia} style={{ width: 60, marginRight: 10 }} />
                    <span>Assistência técnica em equipamentos</span>
                </div>

                <div id='listServ'>
                    <img src={IconAulas} style={{ width: 60, marginRight: 10 }} />
                    <span>Aulas</span>
                </div>

                <div id='listServ'>
                    <img src={IconDesenvolvimento} style={{ width: 60, marginRight: 10 }} />
                    <span>Design e desenvolvimento</span>
                </div>

                <div id='listServ'>
                    <img src={IconEventos} style={{ width: 60, marginRight: 10 }} />
                    <span>Eventos</span>
                </div>

                <div id='listServ'>
                    <img src={IconModa} style={{ width: 60, marginRight: 10 }} />
                    <span>Moda e beleza</span>
                </div>

                <div id='listServ'>
                    <img src={IconReformas} style={{ width: 60, marginRight: 10 }} />
                    <span>Reformas e reparo</span>
                </div>

                <div id='listServ'>
                    <img src={IconServicosDom} style={{ width: 60, marginRight: 10 }} />
                    <span>Serviços domésticos</span>
                </div>
            </div>

            <div id='areaRightServicos'>
                <div id='top'>
                    <div style={{ flexDirection: 'row', display: 'flex', height: '50%', alignItems: 'center' }}>
                        <span style={{ marginRight: 25 }}>Diversos profissionais disponíveis para <br />
                            os mais variados <strong>serviços.</strong></span>
                        <div style={{ marginTop: 100 }}>
                            <div style={{ backgroundColor: '#390099', height: 20, width: 200, marginBottom: 15 }}></div>
                            <div style={{ backgroundColor: '#390099', height: 20, width: 200, marginBottom: 15 }}></div>
                            <div style={{ backgroundColor: '#390099', height: 20, width: 200, marginBottom: 15 }}></div>
                            <div style={{ backgroundColor: '#390099', height: 20, width: 200, marginBottom: 15 }}></div>
                        </div>
                    </div>
                </div>
                <div id='bottom'>
                    <img src={Image} />
                </div>
            </div>
        </div>
    );
}

export default Servicos;