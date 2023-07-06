import React, { useState, useEffect } from 'react';
import './styles.css';
import InputMask from 'react-input-mask';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import Select from '@mui/material/Select';
import MenuItem from '@mui/material/MenuItem';
import Alert from '@mui/material/Alert';
import OutlinedInput from '@mui/material/OutlinedInput';
import IconButton from '@mui/material/IconButton';
import VisibilityOff from '@mui/icons-material/VisibilityOff';
import InputAdornment from '@mui/material/InputAdornment';
import InputLabel from '@mui/material/InputLabel';
import Visibility from '@mui/icons-material/Visibility';
import FormControl from '@mui/material/FormControl';
import axios from 'axios';

function Register() {
  const [type, setType] = useState('');
  const [firstName, setFirstName] = useState('');
  const [lastName, setLastName] = useState('');
  const [cpf, setCpf] = useState('');
  const [mail, setMail] = useState('');
  const [number, setNumber] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const [passwordsMatch, setPasswordsMatch] = useState(true);
  const [showPassword, setShowPassword] = React.useState(false);
  const [error, setError] = useState(false);
  const [errorText, setErrorText] = useState('');


  const handleClickShowPassword = () => setShowPassword((show) => !show);

  const handleMouseDownPassword = (event) => {
    event.preventDefault();
  };

  const handleChange = (event) => {
    setType(event.target.value);
  };

  const handleCpfChange = (event) => {
    setCpf(event.target.value);
  };

  const handleTelefoneChange = (event) => {
    setNumber(event.target.value);
  };

  function sendForm() {
    if (password === confirmPassword) {
      const user = {
        firstName: firstName,
        lastName: lastName,
        cpfCnpj: cpf,
        tipoPessoa: type,
        email: mail,
        password: password,
        number: number,
        createdAt: new Date().toISOString(),
        updatedAt: new Date().toISOString(),
      };

      axios.post('https://localhost:7024/api/Users', user, { mode: 'no cors' })
        .then((response) => {
          console.log(response.data);
        })
        .catch((error) => {
          if(error.response.status === 400) {
            setErrorText(error.response.data);
            setError(true);
          }
        });
    } else {
      setPasswordsMatch(false);
    }
  };

  //FUNÇÃO QUE CONDICIONA O QUE SERÁ EXIBIDO A PARTIR DO VALOR DO SELECT
  const renderFields = () => {
    if (type === '1') {
      return (
        <>
          <TextField
            onChange={(event) => setFirstName(event.target.value)}
            style={{ marginBottom: 22, width: '60%' }}
            id="outlined-basic"
            label="Primeiro Nome"
            variant="outlined"
          />
          <TextField
            onChange={(event) => setLastName(event.target.value)}
            style={{ marginBottom: 22, width: '60%' }}
            id="outlined-basic"
            label="Último Nome"
            variant="outlined"
          />
          <InputMask mask="999.999.999-99" maskChar=" " onChange={handleCpfChange}>
            {() => (
              <TextField
                style={{ marginBottom: 22, width: '60%' }}
                id="outlined-basic"
                label="CPF"
                variant="outlined"
              />
            )}
          </InputMask>
          <TextField
            onChange={(event) => setMail(event.target.value)}
            style={{ marginBottom: 22, width: '60%' }}
            id="outlined-basic"
            label="E-mail"
            variant="outlined"
          />
          <InputMask mask="99 99999-9999" maskChar=" " onChange={handleTelefoneChange}>
            {() => (
              <TextField
                style={{ marginBottom: 22, width: '60%' }}
                id="outlined-basic"
                label="Telefone"
                variant="outlined"
              />
            )}
          </InputMask>
          <FormControl sx={{ m: 1, width: '60%' }} variant="outlined">
            <InputLabel htmlFor="outlined-adornment-password">Crie uma senha</InputLabel>
            <OutlinedInput
              id="outlined-adornment-password"
              type={showPassword ? 'text' : 'password'}
              onChange={(event) => setPassword(event.target.value)}
              endAdornment={
                <InputAdornment position="end">
                  <IconButton
                    aria-label="toggle password visibility"
                    onClick={handleClickShowPassword}
                    onMouseDown={handleMouseDownPassword}
                    edge="end"
                  >
                    {showPassword ? <VisibilityOff /> : <Visibility />}
                  </IconButton>
                </InputAdornment>
              }
              label="Password"
            />
          </FormControl>
          <FormControl sx={{ m: 1, width: '60%' }} variant="outlined">
            <InputLabel htmlFor="outlined-adornment-password">Confirme sua senha</InputLabel>
            <OutlinedInput
              id="outlined-adornment-password"
              type={showPassword ? 'text' : 'password'}
              onChange={(event) => setConfirmPassword(event.target.value)}
              endAdornment={
                <InputAdornment position="end">
                  <IconButton
                    aria-label="toggle password visibility"
                    onClick={handleClickShowPassword}
                    onMouseDown={handleMouseDownPassword}
                    edge="end"
                  >
                    {showPassword ? <VisibilityOff /> : <Visibility />}
                  </IconButton>
                </InputAdornment>
              }
              label="Password"
            />
          </FormControl>
          <br></br>
          <Button style={{ marginBottom: 20, width: '60%' }} variant="contained"
            onClick={() => sendForm()}>
            Salvar
          </Button>
          <br></br>
        </>
      );
    } else if (type === '2') {
      return (
        <>
          <TextField
            onChange={(event) => setFirstName(event.target.value)}
            style={{ marginBottom: 22, width: '60%' }}
            id="outlined-basic"
            label="Razão Social"
            variant="outlined"
          />
          <TextField
            onChange={(event) => setLastName(event.target.value)}
            style={{ marginBottom: 22, width: '60%' }}
            id="outlined-basic"
            label="Fantasia"
            variant="outlined"
          />
          <InputMask mask="99999999999999" maskChar=" " onChange={handleCpfChange}>
            {() => (
              <TextField
                style={{ marginBottom: 22, width: '60%' }}
                id="outlined-basic"
                label="CNPJ"
                variant="outlined"
              />
            )}
          </InputMask>
          <TextField
            onChange={(event) => setMail(event.target.value)}
            style={{ marginBottom: 22, width: '60%' }}
            id="outlined-basic"
            label="E-mail"
            variant="outlined"
          />
          <InputMask mask="99 99999-9999" maskChar=" " onChange={handleTelefoneChange}>
            {() => (
              <TextField
                style={{ marginBottom: 22, width: '60%' }}
                id="outlined-basic"
                label="Telefone"
                variant="outlined"
              />
            )}
          </InputMask>
          <FormControl sx={{ m: 1, width: '60%' }} variant="outlined">
            <InputLabel htmlFor="outlined-adornment-password">Crie uma senha</InputLabel>
            <OutlinedInput
              id="outlined-adornment-password"
              type={showPassword ? 'text' : 'password'}
              onChange={(event) => setPassword(event.target.value)}
              endAdornment={
                <InputAdornment position="end">
                  <IconButton
                    aria-label="toggle password visibility"
                    onClick={handleClickShowPassword}
                    onMouseDown={handleMouseDownPassword}
                    edge="end"
                  >
                    {showPassword ? <VisibilityOff /> : <Visibility />}
                  </IconButton>
                </InputAdornment>
              }
              label="Password"
            />
          </FormControl>
          <FormControl sx={{ m: 1, width: '60%' }} variant="outlined">
            <InputLabel htmlFor="outlined-adornment-password">Confirme sua senha</InputLabel>
            <OutlinedInput
              id="outlined-adornment-password"
              type={showPassword ? 'text' : 'password'}
              onChange={(event) => setConfirmPassword(event.target.value)}
              endAdornment={
                <InputAdornment position="end">
                  <IconButton
                    aria-label="toggle password visibility"
                    onClick={handleClickShowPassword}
                    onMouseDown={handleMouseDownPassword}
                    edge="end"
                  >
                    {showPassword ? <VisibilityOff /> : <Visibility />}
                  </IconButton>
                </InputAdornment>
              }
              label="Password"
            />
          </FormControl>
          <br></br>
          <Button style={{ marginBottom: 20, width: '60%' }} variant="contained"
            onClick={() => sendForm()}>
            Salvar
          </Button>
          <br></br>
        </>
      );
    }
  };

  return (
    <div id="containerRegister" style={{ height: '100vh' }}>
      <div id="areaLeftRegister">
        <span style={{ color: '#FFF', marginRight: '20%' }}>
          O primeiro passo para <br />
          <strong>solucionar</strong> o seu problema.
        </span>
        <div id="faixaBranca"></div>
      </div>

      <div id="areaRightRegister">
        <span style={{ fontSize: 25, margin: 25 }}>
          <strong>Quero</strong>
          <span style={{ color: '#390099' }}>Serviços</span>
        </span>
        <br></br>
        {!passwordsMatch && (
          <Alert severity="error" style={{ marginBottom: 22, width: '60%' }}>
            As senhas digitadas não são iguais.
          </Alert>
        )}
        {error && (
          <Alert severity="error" style={{ marginBottom: 22, width: '60%' }}>
            {errorText}
          </Alert>
        ) 
        }
        <br></br>
        <Select
          style={{ marginBottom: 22, width: '60%' }}
          labelId="demo-simple-select-label"
          id="demo-simple-select"
          value={type}
          label="Tipo"
          onChange={handleChange}
          placeholder="Tipo"
        >
          <MenuItem value="1">Pessoa Física</MenuItem>
          <MenuItem value="2">Pessoa Jurídica</MenuItem>
        </Select>
        {type !== '' && renderFields()}

      </div>
    </div>
  );
}

export default Register;
