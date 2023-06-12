import React from 'react';
import './styles.css'
import Checkbox from '@mui/material/Checkbox';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import Box from '@mui/material/Box';
import Modal from '@mui/material/Modal';

const style = {
    position: 'absolute',
    top: '50%',
    left: '50%',
    transform: 'translate(-50%, -50%)',
    bgcolor: 'background.paper',
    border: '2px solid #000',
    boxShadow: 24,
    p: 4,
    display: 'flex',
    alignItems: 'center',
    flexDirection: 'column'
  };

const label = { inputProps: { 'aria-label': 'Checkbox demo' } };

function Login() {
    const [open, setOpen] = React.useState(false);
    const handleOpen = () => setOpen(true);
    const handleClose = () => setOpen(false);
    return (
        <div id='containerLogin'>
            <div id='areaLeftLogin'>
                <span style={{ color: '#FFF', marginRight: '20%' }}>
                    O primeiro passo para <br />
                    <strong>solucionar</strong> o seu problema.
                </span>
                <div id='faixaBranca'></div>
            </div>
            <div id='areaRightLogin'>
                <div id='areaLogin'>
                    <span style={{ fontSize: 25, margin: 20 }}><strong>Quero</strong><span style={{ color: '#390099' }}>Serviços</span></span>

                    <TextField style={{ marginBottom: 22, width: '80%' }} id="outlined-basic" label="E-mail" variant="outlined" />

                    <TextField style={{ marginBottom: 5, width: '80%' }} id="outlined-basic" label="Senha" type='password' variant="outlined" />

                    <div style={{ display: 'flex', flexDirection: 'row', alignItems: 'center' }}>
                        <Checkbox {...label} defaultChecked /> <span>Lembrar a senha</span>
                    </div>

                    <Button variant="contained">acessar</Button>
                    
                    <span style={{ marginTop: 15 }}>não possui login? <a href='/' style={{ fontSize: 16, color: '#000', textDecoration: 'underline' }}>cadastre-se</a></span>
                    <Button onClick={handleOpen} style={{ marginTop: 5, fontSize: 16, color: '#000', textDecoration: 'underline' }}>esqueceu a senha?</Button>
                </div>
            </div>
            <Modal
                open={open}
                onClose={handleClose}
                aria-labelledby="modal-modal-title"
                aria-describedby="modal-modal-description"
            >
                <Box sx={style}>
                    <span style={{marginBottom: 15}}>Digite seu e-mail para recuperar sua senha</span>
                    <TextField style={{ marginBottom: 22, width: '80%' }} id="outlined-basic" label="E-mail" variant="outlined" />
                    <Button variant="contained">Enviar</Button>
                </Box>
            </Modal>
        </div>
    )
}

export default Login;