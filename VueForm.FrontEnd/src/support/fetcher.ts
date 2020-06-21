async function fetchApi (
  callback: any,
  url: string,
  method: string,
  body?: any
) {
  const token = localStorage.Token
  let header
  let data
  if (token !== null) {
    header = new Headers({
      'Content-Type': 'application/json'
    })
  }
  const res = await fetch(url, { method, body, headers: header })
  try {
    data = await res.json()
  } catch {
    data = {
      error: 'Invalid data format'
    }
    if (callback !== null) {
      callback(data, 500)
    }
    return { data, status: 500 }
  }
  if (callback !== null) {
    callback(data, res.status)
  }
  return { data, status: res.status }
}
export default fetchApi
