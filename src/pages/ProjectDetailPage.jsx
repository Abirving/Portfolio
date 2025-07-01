import { motion } from "framer-motion";
import { useParams } from "react-router-dom"; // assuming you're using React Router
import { useEffect, useState } from "react";

const ProjectDetailPage = () => {
  const { projectId } = useParams(); // e.g. "AK_Hospital"

  // Mock project data — in production, this could come from an API or context
  const projectData = {
    "AK_Hospital": {
      title: "E-commerce Website",
      description: "A full-stack online shopping platform with user authentication and payment integration.",
      image: "/images/projects/ecommerce.jpg",
      zipLink: "/projects/AK_Hospital/project.zip"
    },
    "task-management-app": {
      title: "Task Management App",
      description: "A productivity app to manage tasks and collaborate with teams in real-time.",
      image: "/images/projects/task-app.jpg",
      zipLink: "/projects/task-management-app/project.zip"
    },
    "weather-dashboard": {
      title: "Weather Dashboard",
      description: "A weather app that provides real-time weather updates for any location.",
      image: "/images/projects/weather.jpg",
      zipLink: "/projects/weather-dashboard/project.zip"
    },
    "mobile-game-app": {
      title: "Mobile Game App",
      description: "A fun mobile game built with React Native for iOS and Android platforms.",
      image: "/images/projects/game.jpg",
      zipLink: "/projects/mobile-game-app/project.zip"
    }
  };

  const project = projectData[projectId];

  const [notFound, setNotFound] = useState(false);

  useEffect(() => {
    if (!project) {
      setNotFound(true);
    }
  }, [projectId, project]);

  if (notFound) {
    return (
      <div className="min-h-screen flex items-center justify-center bg-gray-100 dark:bg-gray-900 text-red-500 text-2xl">
        Project not found!
      </div>
    );
  }

  return (
    <motion.div
      initial={{ opacity: 0 }}
      animate={{ opacity: 1 }}
      exit={{ opacity: 0 }}
      className="min-h-screen py-12 px-4 bg-gray-100 dark:bg-gray-900"
    >
      <motion.div
        initial={{ y: 30, opacity: 0 }}
        animate={{ y: 0, opacity: 1 }}
        transition={{ duration: 0.6 }}
        className="max-w-3xl mx-auto bg-white dark:bg-gray-800 rounded-xl shadow-lg overflow-hidden"
      >
        {/* Project Image */}
        <div className="relative h-64 md:h-80 w-full">
          <img
            src={project.image}
            alt={`${project.title} Preview`}
            className="w-full h-full object-cover"
          />
        </div>

        {/* Content */}
        <div className="p-8 space-y-6">
          <h2 className="text-3xl font-bold text-gray-800 dark:text-white">{project.title}</h2>
          <p className="text-gray-600 dark:text-gray-300">{project.description}</p>

          {/* Download Button */}
          <motion.a
            href={project.zipLink}
            download
            whileHover={{ scale: 1.03 }}
            whileTap={{ scale: 0.97 }}
            className="inline-block px-6 py-3 bg-purple-600 hover:bg-purple-700 text-white font-medium rounded-lg cursor-pointer transition-colors"
          >
            📦 Download ZIP File
          </motion.a>
        </div>
      </motion.div>
    </motion.div>
  );
};

export default ProjectDetailPage;