async function getData() {
  const url = "http://localhost:5257/zoo";
  try {
    const response = await fetch(url);
    if (!response.ok) {
      throw new Error('Response status: ${response.status}');
    }
    
    const result = await response.json();
    console.log(result);
    } catch (error) {
      console.error(error);
    }
}

async function postData(id, animal) {
    const url = "http://localhost:5257/zoo";
    
    try 
    {
        const response = await fetch(url, 
            {
            method: "POST",
            headers: 
                {
                    "Content-Type": "application/json"
                },
            body: JSON.stringify({id: id, animal: animal})
        });
        console.log(response.status);
    } catch (error) 
    {
            console.log(error);
    }
}

await getData();
await postData(5, "Cow");
await getData();
