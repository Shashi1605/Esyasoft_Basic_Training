import React, { useReducer } from 'react'

const reducer = (state, action) => {
    switch (action.type){
        case 'inc':
            return {...state, count:state.count + 1}
        case 'dec':
            return {...state, count:state.count - 1}
        default:
            return state
    }
}

export default function UseReducer() {

    const [state, dispatch] = useReducer(reducer,{count : 0})

  return (
    <div>
      {state.count}<br/>
      <button onClick={()=> dispatch({type :'inc'})} >inc</button>
      <button onClick={()=> dispatch({type : 'dec'})} >dec</button>
    </div>
  )
}
