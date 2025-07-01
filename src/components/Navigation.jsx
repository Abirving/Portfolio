// components/Navigation.jsx
import { Link } from 'react-router-dom';
import ThemeSwitcher from './ThemeSwitcher';

const Navigation = () => {
  return (
    <nav className="flex justify-between items-center p-6 bg-white dark:bg-gray-800 shadow-sm">
      <h1 className="text-2xl font-bold text-purple-600 dark:text-purple-400">My Portfolio</h1>
      <div className="flex gap-6 items-center">
        <Link to="/" className="text-gray-600 dark:text-gray-300 hover:text-purple-600">Home</Link>
        <Link to="/about" className="text-gray-600 dark:text-gray-300 hover:text-purple-600">About</Link>
        <Link to="/projects" className="text-gray-600 dark:text-gray-300 hover:text-purple-600">Projects</Link>
        <Link to="/contact" className="text-gray-600 dark:text-gray-300 hover:text-purple-600">Contact Me</Link>
        <Link to="/skills" className="text-gray-600 dark:text-gray-300 hover:text-purple-600">Skills</Link>
        <ThemeSwitcher />
      </div>
    </nav>
  );
};

export default Navigation;