import React from 'react';
import ReactDOM from 'react-dom';
import Card from './Card';



const App = () => {
    return (
        <div>
            <Card name="Yanky" />
            <h1>Hello everybody!!</h1>
            @ViewBag.message 
        </div>
        )
}


ReactDOM.render(
    <App />,
    document.getElementById('root')
)