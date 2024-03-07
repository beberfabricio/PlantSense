import { create } from 'zustand'
import { GetToken } from '../Components/Helpers/TokenHelper';
import axios from 'axios'

export const usePermissionStore = create((set) => ({
  permissions: [],
  fetchPermissions: () => {
    axios.get('https://localhost:7246/permissions', {
        headers: {
          Authorization: GetToken()
        }
      })
      .then(res => set({ permissions: res.data }))
      .catch(err => console.log(err));
  },
}));