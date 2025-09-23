import { useEffect, useState } from "react";
import axios from "axios";

const useFetch = (url) => {
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);
  const [data, setData] = useState(null);

  const getdata = async () => {
    try {
      setLoading(true);
      const response = await axios.get(url);
      console.log(response)
      setData(response.data);
    } catch (error) {
      setError(error);
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    getdata();
  }, []);

  return [loading, error, data];
};
export default useFetch;
