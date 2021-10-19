import React from 'react';
import ReactDOM from 'react-dom';
import Card from './Card';



const App = () => {
    return (
        <div>
            <Card name="Clanky" />
            <h1>This is app111111111!!!!!!</h1>
        </div>
    )
}


ReactDOM.render(
    <App />,
    document.getElementById('root1')
)