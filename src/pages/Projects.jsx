import { motion } from "framer-motion";

const Projects = () => {
  const projects = [
    {
      title: "Hospital Managment System",
      description: "A Hospital managment system platform with user authentication and payment integration.",
      tech: ["Php", "SQL", "Java"],
      image: "/images/projects/hos.jpg", // Local image path
      
    },
    {
      title: "Blood Bank Managment System",
      description: "A productivity webapp to manage tasks and and collect information for blood bank.",
      tech: ["Php", "SQL", "Java","TailwindCSS"],
      image: "/images/projects/hopp.jpg", // Local image path
      
    },
    {
      title: "Food Delivery",
      description: "A Food delivery website with a cart and shopping platforms.",
      tech: ["JavaScript", "Php", "SQL", "Chart.js"],
      image: "/images/projects/foo.jpg", // Local image path
     
    },
    {
      title: "Pharmacy Managment",
      description: "A fun mobile game built with React Native for iOS and Android platforms.",
      tech: ["Php", "SQL", "Java"],
      image: "/images/projects/phar.jpg", // Local image path
     
    },
  ];

  // Animation Variants
  const containerVariants = {
    hidden: { opacity: 0 },
    visible: {
      opacity: 1,
      transition: {
        staggerChildren: 0.2,
      },
    },
  };

  const itemVariants = {
    hidden: { opacity: 0, y: 50 },
    visible: { opacity: 1, y: 0, transition: { duration: 0.6, ease: "easeOut" } },
  };

  return (
    <motion.div
      initial={{ opacity: 0 }}
      animate={{ opacity: 1 }}
      exit={{ opacity: 0 }}
      className="min-h-screen py-16 px-4 bg-gradient-to-b from-gray-100 to-white dark:from-gray-900 dark:to-gray-800"
    >
      <motion.h2
        initial={{ opacity: 0, y: -20 }}
        animate={{ opacity: 1, y: 0 }}
        transition={{ duration: 0.8 }}
        className="text-4xl font-bold text-center mb-12 text-transparent bg-clip-text bg-gradient-to-r from-purple-600 to-blue-600"
      >
        My Projects
      </motion.h2>

      <motion.div
        variants={containerVariants}
        initial="hidden"
        animate="visible"
        className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8"
      >
        {projects.map((project, index) => (
          <motion.div
            key={index}
            variants={itemVariants}
            whileHover={{ scale: 1.05 }}
            whileTap={{ scale: 0.95 }}
            className="bg-white dark:bg-gray-800 rounded-2xl overflow-hidden shadow-lg hover:shadow-xl transition-shadow"
          >
            {/* Project Image */}
            <div className="relative h-48 w-full">
              <img
                src={project.image}
                alt={project.title}
                className="w-full h-full object-cover"
              />
            </div>

            {/* Project Details */}
            <div className="p-6 space-y-4">
              <h3 className="text-xl font-semibold text-gray-800 dark:text-white">
                {project.title}
              </h3>
              <p className="text-gray-600 dark:text-gray-300">{project.description}</p>

              {/* Tech Stack */}
              <div className="flex items-center gap-2 flex-wrap">
                {project.tech.map((tech, idx) => (
                  <span
                    key={idx}
                    className="px-3 py-1 text-sm bg-gray-200 dark:bg-gray-700 rounded-full text-gray-700 dark:text-gray-300"
                  >
                    {tech}
                  </span>
                ))}
              </div>

              {/* Download Button */}
              
            </div>
          </motion.div>
        ))}
      </motion.div>
    </motion.div>
  );
};

export default Projects;