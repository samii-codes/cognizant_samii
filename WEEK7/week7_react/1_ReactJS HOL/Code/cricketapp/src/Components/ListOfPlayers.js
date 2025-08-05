import react from 'react';



const ListOfPlayers = (props) => {
    return (
        props.players.map((player, index) => {
            return(
        
                <div>
                    <li>Mr.{player.name} <span>{player.score}</span></li>
                </div>
            )
        })
    );
}

const ScoreBelow70=(props)=>{
    return (
        props.players.filter(player => player.score < 70).map((player, index) => {
            return(
                <div>
                    <li>Mr.{player.name} <span>{player.score}</span></li>
                </div>
            )
        })
    );

}

export { ListOfPlayers, ScoreBelow70};


