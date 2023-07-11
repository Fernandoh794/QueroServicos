import React, { useEffect, useState } from 'react';
import Chip from '@mui/material/Chip';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import FavoriteIcon from '@mui/icons-material/Favorite';
import { useNavigate } from 'react-router-dom';

export default function MediaCard({ users }) {
  const navigate = useNavigate();

  const handleSaibaMais = (userId) => {
    navigate(`/datePage?userId=${userId}`);
  };
  return (
    <>
      {users.map(user => (
        <Card key={user.id} sx={{ flexBasis: '30%', marginBottom: '20px',maxWidth: 345, border: 'solid', borderWidth: 1 }}>
          <CardMedia
            sx={{ height: 140 }}
            src='https://th.bing.com/th/id/R.a56db442e6c48befe6588f592a78dd68?rik=PgCpaNPowkF1VQ&riu=http%3a%2f%2ffreepngimg.com%2fdownload%2figuana%2f27315-1-iguana-transparent-background.png&ehk=BkRVpbK8AstdCfaDIao3Rd7fKBtJVjECvtkAiVK02R4%3d&risl=&pid=ImgRaw&r=0'
            title="green iguana"
          />
          <CardContent>
            <Typography gutterBottom variant="h5" component="div">
              {user.firstName} {user.lastName}
            </Typography>
            <Typography variant="body2" color="text.secondary">
              {user.email}
            </Typography>
            <Chip label={user.contactId} />
          </CardContent>
          <CardActions>
            <Button size="small">
              <FavoriteIcon />
            </Button>
            <Button size="small" onClick={() => handleSaibaMais(user.id)}>Saiba Mais</Button>
          </CardActions>
        </Card>
      ))}
    </>
  );
}
