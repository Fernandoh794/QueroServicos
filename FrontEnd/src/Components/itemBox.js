import React from 'react';
import Image1 from '../assets/icon-auto.png'
import Image2 from '../assets/icon-assistencia.png'
import Image3 from '../assets/icon-aula.png'
import Image4 from '../assets/icon-desenvolvimento.png'
import Image5 from '../assets/icon-eventos.png'
import Image6 from '../assets/icon-moda.png'
import Image7 from '../assets/icon-reformas.png'
import Image8 from '../assets/icon-servicosdomesticos.png'
import Button from '@mui/material/Button';

function ItemBox() {
    return (
        <div style={{display: 'flex', flex: 'row', margin: 'auto'}}>
            <Button style={{ display: 'flex', flexDirection: 'column' }}>
                <img src={Image1} style={{ width: 80 }} />
                <h5 style={{color: '#000'}}>Peças e <br/>auto</h5>
            </Button>
            <Button style={{ display: 'flex', flexDirection: 'column' }}>
                <img src={Image2} style={{ width: 80 }} />
                <h5 style={{color: '#000'}}>Assistência <br/>Técnica</h5>
            </Button>
            <Button style={{ display: 'flex', flexDirection: 'column' }}>
                <img src={Image3} style={{ width: 80 }} />
                <h5 style={{color: '#000'}}>Aulas</h5>
            </Button>
            <Button style={{ display: 'flex', flexDirection: 'column' }}>
                <img src={Image4} style={{ width: 80 }} />
                <h5 style={{color: '#000'}}>Design e <br/>software</h5>
            </Button>
            <Button style={{ display: 'flex', flexDirection: 'column' }}>
                <img src={Image5} style={{ width: 80 }} />
                <h5 style={{color: '#000'}}>Eventos</h5>
            </Button>
            <Button style={{ display: 'flex', flexDirection: 'column' }}>
                <img src={Image6} style={{ width: 80 }} />
                <h5 style={{color: '#000'}}>Moda e <br/>Beleza</h5>
            </Button>
            <Button style={{ display: 'flex', flexDirection: 'column' }}>
                <img src={Image7} style={{ width: 80 }} />
                <h5 style={{color: '#000'}}>Reparos e <br/>reformas</h5>
            </Button>
            <Button style={{ display: 'flex', flexDirection: 'column' }}>
                <img src={Image8} style={{ width: 80 }} />
                <h5 style={{color: '#000'}}>Serviços <br/>domésticos</h5>
            </Button>
        </div>
    )
}

export default ItemBox;