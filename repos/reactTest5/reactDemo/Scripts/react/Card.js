import React, { useState } from 'react';

const Card = (props) => {
    const [name, setName] = useState("");

    const changeName = (e) => {
        setName(e.target);
    }

    return (
        <div>
            <h1>Card Component: {props.name}</h1>
            <h3>Card Hook: {name}</h3>
            <input type="text" />
        </div>
    )
}


export default Card;