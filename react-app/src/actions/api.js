import axios from "axios";

const baseUrl = "http://localhost:1232/api/"



export default {

    eAttendee(url = baseUrl + 'EAttendee/') {
        return {
            fetchAll: () => axios.get(url),
            fetchById: id => axios.get(url + id),
            create: newRecord => axios.post(url, newRecord),
            update: (id, updateRecord) => axios.put(url + id, updateRecord),
            delete: id => axios.delete(url + id)
        }
    }
}