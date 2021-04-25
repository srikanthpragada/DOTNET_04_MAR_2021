import requests

resp = requests.get("http://localhost:6420/api/courses")

if resp.status_code != 200:
    print("Sorry! Could not get details!")
    exit()

courses = resp.json()  # Convert JSON to list[dict]
for c in courses:
    print(c['title'])