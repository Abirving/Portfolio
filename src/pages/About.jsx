import { motion } from "framer-motion";
import { FaAward, FaCode, FaBookReader, FaRunning } from "react-icons/fa";
import profileImage from "../image/2.jpg";
const About = () => {
  // Animation Variants
  const containerVariants = {
    hidden: { opacity: 0 },
    visible: {
      opacity: 1,
      transition: {
        staggerChildren: 0.2, // Stagger child animations
      },
    },
  };

  const itemVariants = {
    hidden: { opacity: 0, y: 20 },
    visible: { opacity: 1, y: 0, transition: { duration: 0.6, ease: "easeOut" } },
  };

  return (
    <motion.div
      initial={{ opacity: 0 }}
      animate={{ opacity: 1 }}
      exit={{ opacity: 0 }}
      className="min-h-screen py-16 px-4 bg-gradient-to-b from-gray-100 to-white dark:from-gray-900 dark:to-gray-800"
    >
      {/* Title */}
      <motion.h2
        variants={itemVariants}
        initial="hidden"
        animate="visible"
        className="text-4xl font-bold text-center mb-12 text-transparent bg-clip-text bg-gradient-to-r from-purple-600 to-blue-600"
      >
        About Me
      </motion.h2>

      {/* Content Container */}
      <motion.div
        variants={containerVariants}
        initial="hidden"
        animate="visible"
        className="max-w-4xl mx-auto space-y-8"
      >
        {/* Profile Section */}
        <motion.div
          variants={itemVariants}
          className="flex flex-col md:flex-row items-center gap-8"
        >
          {/* Profile Picture */}
          <motion.div
          variants={itemVariants}
          className="flex justify-center mb-10"
        >
          <div className="w-52 h-62 rounded-full overflow-hidden shadow-lg border-4 border-purple-600">
          <img
  src={profileImage} // Use the imported image
  alt="Profile"
  className="w-full h-full object-cover"
            />
          </div>
        </motion.div>

          {/* Bio */}
          <div className="space-y-4">
            <h3 className="text-2xl font-semibold text-gray-800 dark:text-white">
              Hi, Hailegebriel Samuel!
            </h3>
            <p className="text-gray-600 dark:text-gray-300 leading-relaxed">
              I'm a passionate developer with experience in building modern web applications.
              I specialize in creating responsive, user-friendly interfaces and robust backend systems.
              My goal is to deliver high-quality solutions that solve real-world problems.
            </p>
          </div>
        </motion.div>

        {/* Skills Summary */}
        <motion.div
          variants={itemVariants}
          className="space-y-4"
        >
          <h3 className="text-2xl font-semibold text-gray-800 dark:text-white">What I Do</h3>
          <ul className="space-y-2 text-gray-600 dark:text-gray-300">
            <li className="flex items-center gap-2">
              <FaCode size={20} className="text-purple-600" />
              Develop modern web applications using React, Node.js, and other technologies.
            </li>
            <li className="flex items-center gap-2">
              <FaAward size={20} className="text-purple-600" />
              Build scalable and maintainable backend systems with REST APIs and databases.
            </li>
            <li className="flex items-center gap-2">
              <FaBookReader size={20} className="text-purple-600" />
              Continuously learn new technologies and best practices to stay up-to-date.
            </li>
          </ul>
        </motion.div>

        {/* Personal Interests */}
        <motion.div
          variants={itemVariants}
          className="space-y-4"
        >
          <h3 className="text-2xl font-semibold text-gray-800 dark:text-white">Outside of Work</h3>
          <p className="text-gray-600 dark:text-gray-300 leading-relaxed">
            When I'm not coding, I enjoy exploring new technologies, reading books, and staying active.
            Here are a few things I love:
          </p>
          <div className="flex flex-wrap gap-4">
            <span className="flex items-center gap-2 px-3 py-1 bg-gray-200 dark:bg-gray-700 rounded-full text-gray-700 dark:text-gray-300">
              <FaBookReader size={16} /> Reading
            </span>
            <span className="flex items-center gap-2 px-3 py-1 bg-gray-200 dark:bg-gray-700 rounded-full text-gray-700 dark:text-gray-300">
              <FaRunning size={16} /> Playing Basketball
            </span>
            <span className="flex items-center gap-2 px-3 py-1 bg-gray-200 dark:bg-gray-700 rounded-full text-gray-700 dark:text-gray-300">
              Traveling
            </span>
          </div>
        </motion.div>
      </motion.div>
    </motion.div>
  );
};

export default About;