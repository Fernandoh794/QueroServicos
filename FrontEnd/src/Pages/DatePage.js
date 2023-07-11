import React, { useEffect, useState } from 'react';
import { useLocation } from 'react-router-dom';
import NavbarHome from '../Components/NavbarHome';
import axios from 'axios';
import FavoriteIcon from '@mui/icons-material/Favorite';
import StarIcon from '@mui/icons-material/Star';
import WhatsAppIcon from '@mui/icons-material/WhatsApp';
import MailOutlineIcon from '@mui/icons-material/MailOutline';
import Button from '@mui/material/Button';
import { css } from './DatePage-styles.css';
import Image1 from '../assets/icon-auto.png';
import Image2 from '../assets/icon-assistencia.png';
import Image3 from '../assets/icon-aula.png';
import Image4 from '../assets/icon-desenvolvimento.png';
import Image5 from '../assets/icon-eventos.png';
import Image6 from '../assets/icon-moda.png';
import Image7 from '../assets/icon-reformas.png';
import Image8 from '../assets/icon-servicosdomesticos.png';

function DatePage() {
    const [userData, setUserData] = useState(null);
    const [isFavorite, setIsFavorite] = useState(false); // Track the favorite button state
    const location = useLocation();
    const searchParams = new URLSearchParams(location.search);
    const userId = searchParams.get('userId');

    useEffect(() => {
        const fetchUserData = async () => {
            try {
                const response = await axios.get(`https://localhost:7024/api/Users/${userId}`);
                setUserData(response.data);
            } catch (error) {
                console.error(error);
            }
        };

        if (userId) {
            fetchUserData();
        }
    }, [userId]);

    const handleFavoriteClick = () => {
        setIsFavorite(!isFavorite); // Toggle the favorite button state
    };

    return (
        <div>
            <NavbarHome />
            {userData ? (
                <div id='container-datePage'>
                    <br />
                    <div
                        style={{
                            marginTop: 10,
                            height: '5vh',
                            backgroundColor: '#390099',
                            width: '80%',
                            margin: 'auto',
                            borderRadius: 10,
                            color: '#FFF',
                            textAlign: 'center',
                            fontSize: 22
                        }}
                    >
                        Lagarto
                    </div>

                    <div id='areaInfo'>
                        <div style={{ width: '40%', display: 'flex', justifyContent: 'center' }}>
                            <div style={{ width: '50%', height: '32vh', border: 'solid', borderWidth: 1, borderRadius: 10 }}></div>
                        </div>
                        <div style={{ display: 'flex', flexDirection: 'column', width: '43%' }}>
                            <div>
                                <p style={{ fontSize: 40, margin: 0 }}>
                                    {userData.firstName} {userData.lastName}
                                </p>
                                <p style={{ fontSize: 20, margin: 0 }}>Encanador</p>
                            </div>
                            <div></div>
                            <div>
                                <Button
                                    style={{
                                        backgroundColor: isFavorite ? '#EE4747' : 'transparent',
                                        color: isFavorite ? '#FFF' : '#EE4747',
                                        fontSize: 22,
                                        fontWeight: 'bold',
                                        border: isFavorite ? 'none' : '1px solid #EE4747'
                                    }}
                                    onClick={handleFavoriteClick}
                                >
                                    <FavoriteIcon style={{ color: isFavorite ? '#FFF' : '#EE4747', marginRight: 10 }} />
                                    Favorito
                                </Button>
                            </div>
                        </div>
                        <div style={{ width: '10%', display: 'flex', flexDirection: 'column', alignItems: 'center' }}>
                            <StarIcon style={{ color: '#F7B801', fontSize: 50 }} />
                            <p style={{ fontSize: 35, margin: 0 }}>4.8</p>
                        </div>
                    </div>
                    <div style={{ display: 'flex', flexDirection: 'row', justifyContent: 'center', alignItems: 'center' }}>
                        <WhatsAppIcon sx={{ fontSize: 30, color: '#390099', margin: 1 }} />{' '}
                        <p style={{ fontSize: 15, color: '#1E1E1E' }}>{userData.number}</p>
                        <MailOutlineIcon sx={{ fontSize: 30, color: '#390099', margin: 1, marginLeft: 5 }} />{' '}
                        <p style={{ fontSize: 15, color: '#1E1E1E' }}>{userData.email}</p>
                    </div>
                </div>
            ) : (
                <p>Loading user data...</p>
            )}
        </div>
    );
}

export default DatePage;
