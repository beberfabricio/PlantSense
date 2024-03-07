import React from 'react';
import { Navigate } from 'react-router-dom';


const RouteGuard = ({children, permission}) => {

    const hasValidToken = () => {
        let token = JSON.parse(localStorage.getItem("permissions"));
        if(!token){
            return false;
        }

        if (Date.now() >= token.exp * 1000) {
            localStorage.removeItem('token');
            return false;
        }

        if(!token[permission]){
            return false;
        }

        return true;
    }

   return hasValidToken()
        ? children
        : <Navigate to={{ pathname: '/' }} />
};
 
export default RouteGuard;