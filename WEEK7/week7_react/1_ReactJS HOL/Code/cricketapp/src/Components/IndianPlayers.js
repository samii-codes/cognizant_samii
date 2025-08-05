import React from 'react';


export function OddPlayers({ IndianTeam }) {
    
    const [first, , third, , fifth] = IndianTeam;

    return (
        <div>
            <li>First : {first}</li>
            <li>Third : {third}</li>
            <li>Fifth : {fifth}</li>
        </div>
    );
}


export function EvenPlayers({ IndianTeam }) {
    
    const [, second, , fourth, , sixth] = IndianTeam;

    return (
        <div>
            <li>Second : {second}</li>
            <li>Fourth : {fourth}</li>
            <li>Sixth : {sixth}</li>
        </div>
    );
}


const T20Players = ['First Player', 'Second Player', 'Third Player'];
const RanjiTrophyPlayers = ['Fourth Player', 'Fifth Player', 'Sixth Player'];

export const IndianPlayers = () => {
    const mergedPlayers = [...T20Players, ...RanjiTrophyPlayers];
    return (
        mergedPlayers.map((player, index) => (
            <div key={index}>
                <li>Mr. {player}</li>
            </div>
        ))
    );
};