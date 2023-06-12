import React from 'react';
import Navbar from '../Components/NavbarIndex.js'
import Home from '../Components/Home';
import Conheca from '../Components/Conheca.js';
import Servicos from '../Components/Servicos.js';
import Contato from '../Components/Contato.js';
function Index() {
    return (
        <div className='container'>
            <header>
                <Navbar />
            </header>
            <body>
                <div id='home'>
                    <Home />
                </div>
                <div id='conheca'>
                    <Conheca />
                </div>
                <div id='servico'>
                    <Servicos />
                </div>
                <div id='contato'>
                    <Contato />
                </div>
            </body>
        </div>
    )
}

export default Index;