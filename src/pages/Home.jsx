import { motion } from "framer-motion";
import { FaDownload, FaCode, FaPaintBrush } from "react-icons/fa";
import profileImage from "../image/2.jpg";
const Home = () => {
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
      {/* Content Container */}
      <motion.div
        variants={containerVariants}
        initial="hidden"
        animate="visible"
        className="max-w-4xl mx-auto text-center space-y-8"
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

        {/* Title and Tagline */}
        <motion.h1
          variants={itemVariants}
          className="text-5xl font-bold text-transparent bg-clip-text bg-gradient-to-r from-purple-600 to-blue-600"
        >
          Hi, I'm <span className="font-extrabold">Hailegebriel</span>
        </motion.h1>
        <motion.p
          variants={itemVariants}
          className="text-xl text-gray-600 dark:text-gray-300 leading-relaxed"
        >
          Frontend Developer & UI Designer  | Crafting beautiful, functional, and user-friendly web experiences.
        </motion.p>

        {/* Call-to-Action Buttons */}
        <motion.div
          variants={itemVariants}
          className="flex justify-center gap-4 mt-8"
        >
          <a
            href="/projects" // Update with your projects page route
            className="bg-purple-600 text-white px-6 py-3 rounded-lg hover:bg-purple-700 transition-colors flex items-center gap-2"
          >
            <FaCode size={20} /> View Projects
          </a>
          <a
            href="/images/projects/CV.pdf" // Update with your CV file link
            download
            className="border-2 border-purple-600 text-purple-600 px-6 py-3 rounded-lg hover:bg-purple-50 dark:hover:bg-purple-900 transition-colors flex items-center gap-2"
          >
            <FaDownload size={20} /> Download CV
          </a>
        </motion.div>

        {/* Skills Highlights */}
        <motion.div
          variants={itemVariants}
          className="mt-12 space-y-4"
        >
          <h3 className="text-2xl font-semibold text-gray-800 dark:text-white">What I Do</h3>
          <div className="flex justify-center gap-8">
            <div className="flex flex-col items-center gap-2">
              <FaCode size={40} className="text-purple-600" />
              <p className="text-gray-600 dark:text-gray-300">Frontend Development</p>
            </div>
            <div className="flex flex-col items-center gap-2">
              <FaPaintBrush size={40} className="text-purple-600" />
              <p className="text-gray-600 dark:text-gray-300">UI/UX Design</p>
            </div>
          </div>
        </motion.div>
      </motion.div>
    </motion.div>
  );
};

export default Home;