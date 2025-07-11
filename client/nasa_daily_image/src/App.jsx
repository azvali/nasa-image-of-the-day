import { useState, useEffect } from 'react'
import './App.css'

function App() {
  
  const [date, setDate] = useState('');
  const [title, setTitle] = useState('');
  const [desc, setDesc] = useState('');
  const [imgUrl, setImgUrl] = useState('');

  const getImage = async () => {
    const response = await fetch("http://localhost:5036/api/getImage", {
      method: "GET",
      headers: {"Content-Type": "application/json"}
    });

    if(response.ok){
      const data = await response.json();
    
      setDate(data.date);
      setTitle(data.title);
      setDesc(data.explanation);
      setImgUrl(data.url);
    }

    console.log("Failed to fetch from api.");
  }

  useEffect(() => {
    getImage();
  },[]);

  return (
    <div className="app-container">
      <div 
        className="background-image" 
        style={{ backgroundImage: `url(${imgUrl})` }} 
      />
      <div className='container'>
        <div className='header-container'>
          <h1>{title}</h1>
          <p>{date}</p>
        </div>
        <div className='img-container'>
          <img src={imgUrl} alt={title} className="media-item"></img>
        </div>
        <div className='footer'>
          {desc}
        </div>
      </div>
    </div>
  )
}

export default App
