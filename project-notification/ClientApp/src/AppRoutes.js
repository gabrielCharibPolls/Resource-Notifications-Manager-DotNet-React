
import LoginPage from './components/LoginPage'
import { Navigate } from 'react-router-dom';
import { Redirect } from 'react-router-dom';
const AppRoutes = [


    {
        path: '/login',
        element: <LoginPage />
    },
    {
        path: '*',
        element: <Navigate to="/login" replace />
    }


];

export default AppRoutes;
