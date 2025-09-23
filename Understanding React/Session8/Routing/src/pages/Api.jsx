import React from 'react'
import UseFetch from '../Hooks/UseFetch'

export default function Api() {
    const [loading, error, data] = UseFetch("https://jsonplaceholder.typicode.com/posts")
  return (
    <div>
      {
        loading && <>loading...</>
      }
      {
        !loading && error && <>{error.message}</>
      }
      {
        !loading && !error && data && data.map((element) => <p key = {element.id}> {element.id}. {element.title}</p>)
      }
    </div>
  )
}
